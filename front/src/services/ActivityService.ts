import TimePassedActivity from "@/models/dto/TimePassedActivity";
import Activity from "../models/dto/Activity";

export default class ActivityService {
    private baseUrl : string = 'http://localhost:5049/api/activities';

    async getAll(): Promise<Activity[]> {
        const headers: Headers = new Headers();
        headers.set('Content-Type', 'application/json');
        headers.set('Accept', 'application/json');

        const request: RequestInfo = new Request(this.baseUrl, {
            method: 'GET',
            headers: headers
        });

        return fetch(request)
            .then(res => res.json())
            .then((rawActivities: Activity[]) => {
                return rawActivities.map(rawActivity => {
                    const activity = new Activity(rawActivity.name, rawActivity.description, rawActivity.id);

                    // Vérifiez si rawActivity a un tableau timePassed
                    if (rawActivity.timePassed) {
                        rawActivity.timePassed.forEach(time => {
                            console.log("cadeau la team", time);
                            // Assurez-vous que time a bien les propriétés attendues
                            if (time.begin && time.end) {
                                activity.addActivityTime(new TimePassedActivity(time.begin, time.end, time.date));
                            } else {
                                console.warn("time est mal défini :", time);
                            }
                        });
                    } else {
                        console.warn("timePassed est undefined pour l'activité :", rawActivity);
                    }
                    
                    return activity; // Retournez l'instance d'activité
                });
            });
    }

    // Méthode pour ajouter une nouvelle activité
    async add(nom: string, description: string): Promise<Activity> {
        return new Activity("a", "2");
    }
}
