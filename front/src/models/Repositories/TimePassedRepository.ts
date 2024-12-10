import TimePassedActivityService from '../../services/TimePassedActivity';
import TimePassedActivity from '../dto/TimePassedActivity';

export default class TimePassedRepository {
    private service: TimePassedActivityService;

    constructor() {
        this.service = new TimePassedActivityService();
    }

    public async add(begin : Time, end : Time, date : Date, idActivity : number): Promise<TimePassedActivity> {
       return await this.service.add(begin, end, date, idActivity);
    }
}
