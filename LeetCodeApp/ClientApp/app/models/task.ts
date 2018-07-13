import { Level } from './level';


export class Task {
    constructor(
        public id: number,
        public name: string,
        public level: Level) { }
}