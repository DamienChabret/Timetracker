import TimePassedActivity from "@/models/dto/TimePassedActivity";

export default class TimePassedActivityService{
    private baseUrl : string = 'http://localhost:5049/api/activities';

    async getAll(): Promise<TimePassedActivity[]> {
      return [];
    }

    // Méthode pour ajouter une nouvelle activité
    async add(begin : Time, end : Time, date : Date, idActivity : number): Promise<TimePassedActivity> {
      const newObject = {
        begin: begin,
        end: end, 
        date: date,
        idActivity: idActivity
      }
      
       

      // Requête POST -> http://localhost:5049/api/timePassedActivity
      // Body = begin + end + date + idActivity

      return new TimePassedActivity(begin, end, idActivity);
    }
}
