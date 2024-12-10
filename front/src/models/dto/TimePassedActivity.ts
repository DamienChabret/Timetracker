/**
 * Temps passé pour une activité 
 */
export default class TimePassedActivity {
    date: number;
    begin: Time;
    end: Time;

    constructor(
        begin: Time,
        end: Time,
        date: number
    ) {
        this.date = date;
        this.begin = begin;
        this.end = end;
    }

    get Time(): { hours: number; minutes: number } {
        const minutes = 60;

        // Conversion des heures en minutes                
        const totalBeginMinutes = this.begin.hours * minutes + this.begin.minutes;
        const totalEndMinutes = this.end.hours * minutes + this.end.minutes;
        const diffMinutes = totalEndMinutes - totalBeginMinutes;

        // Calcul du temps passé
        const hoursPassed = Math.floor(diffMinutes / minutes); // Utilisation de `Math.floor` pour éviter un arrondi incorrect
        const minutesPassed = diffMinutes % minutes;

        return {
            hours: hoursPassed,
            minutes: minutesPassed
        };
    }
}
