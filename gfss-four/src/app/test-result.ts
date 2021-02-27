export class TestResult {

    constructor(ts: string, scss: boolean) {
        this.testString = ts;
        this.success = scss;
    }
    
    public testString = '';
    public success = false;
}
