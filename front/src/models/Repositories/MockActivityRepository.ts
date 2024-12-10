import Activity from "../dto/Activity";

export default class ActivityRepository {
    private listActivities: Activity[];

    constructor() {
        this.listActivities = [];
        // Ajout d'exemples d'activités pour l'initialisation
        this.addActivity(new Activity("lorem ipsum", "lorem ipsum lorem ipsum", 1));
        this.addActivity(new Activity("lorem ipsum", "lorem ipsum lorem ipsum", 2));
        this.addActivity(new Activity("lorem ipsum", "lorem ipsum lorem ipsum", 3));
        this.addActivity(new Activity("lorem ipsum", "lorem ipsum lorem ipsum", 4));
        this.addActivity(new Activity("lorem ipsum", "lorem ipsum lorem ipsum", 5));
    }

    public addActivity(activity: Activity): void {
        if (!(activity instanceof Activity)) {
            throw new TypeError("Expected an instance of Activity");
        }
        this.listActivities.push(activity);
    }

    public totalTimeActivity(): Time {
        const time: Time = {
            hours: 0,
            minutes: 0,
        };

        this.listActivities.forEach((activity) => {
            time.hours += activity.TotalTime.hours;
            time.minutes += activity.TotalTime.minutes;
        });

        // Convertir les minutes en heures si nécessaire
        if (time.minutes >= 60) {
            time.hours += Math.floor(time.minutes / 60);
            time.minutes = time.minutes % 60;
        }

        return time;
    }
}
