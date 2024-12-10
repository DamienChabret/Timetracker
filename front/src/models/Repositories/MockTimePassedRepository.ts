export default class TimePassedRepository {
    constructor() {
        // Ici, tu peux initialiser des propriétés si nécessaire.
    }

    public add(
        begin : Time,
        end : Time,
        idActivity: number
    ): void {
        console.log(begin, end, idActivity);
    }
}
