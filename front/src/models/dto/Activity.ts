import TimePassedActivity from "./TimePassedActivity";

/**
 * Activités
 */
export default class Activity {
    id: number | null;
    name: string;
    description: string;
    timePassed: TimePassedActivity[];

    constructor(name: string, description: string, id: number | null = null) {
        this.id = id;
        this.name = name;
        this.description = description;
        this.timePassed = [];
    }

    public addActivityTime(activity: TimePassedActivity): void {
        if (!(activity instanceof TimePassedActivity)) {
            throw new TypeError("Expected an instance of TimePassedActivity");
        }
        this.timePassed.push(activity);
    }

    public AddTime(
        begin: Time,
        end: Time,
        date: number
    ) : void {
        this.timePassed.push(new TimePassedActivity(begin, end, date));
    }

    public Fill(activity: { name: string; description: string; timePassed: TimePassedActivity[] }): void {
        this.name = activity.name;
        this.description = activity.description;
        this.timePassed = activity.timePassed;
    }

    public get TotalTime(): Time{
        let totalMinutes = 0;

        // Additionner les heures et les minutes
        for (const activity of this.timePassed as TimePassedActivity[]) {
            const totalMinutesStart = (activity.begin.hours * 60) + (activity.begin.minutes);
            const totalMinutesEnd = (activity.end.hours * 60) + (activity.end.minutes);

            totalMinutes += totalMinutesEnd - totalMinutesStart; // Calcule le temps passé en minutes
        }

        const time: Time = {
            hours: Math.floor(totalMinutes / 60),
            minutes: totalMinutes % 60,
        };

        return time;
    }
}
