import ActivityService from "../../services/ActivityService";
import Activity from "../dto/Activity";
import TimePassedActivity from "../dto/TimePassedActivity";


export default class ActivityRepository {
    private listActivities: Activity[];
    private activityService: ActivityService;

    constructor() {
        this.listActivities = [];
        this.activityService = new ActivityService();
    }

    public async getAllActivities(): Promise<void> {
        this.listActivities = await this.activityService.getAll();
    }

    public async addActivity(activity: Activity): Promise<void> {
        this.listActivities.push(activity);
        await this.activityService.add(activity.name, activity.description);
    }

    /**
     * Calcule le temps passé sur toutes les activités
     * @returns Le nombre d'heure et de minutes que cela à prit 
     */
    public totalTimeActivity(): Time {
        let totalMinutes = 0;

        this.listActivities.forEach((activity) => {
            totalMinutes += (activity.TotalTime.hours * 60) + activity.TotalTime.minutes; // Calcule le temps passé en minutes
        });

        const time: Time = {
            hours: Math.floor(totalMinutes / 60),
            minutes: totalMinutes % 60,
        };

        return time;
    }
}
