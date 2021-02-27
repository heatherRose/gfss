import { Component, OnInit } from '@angular/core';
import { BracketsService } from '../brackets.service';
import { TestResult } from '../test-result';

@Component({
  selector: 'app-brackets-tester',
  templateUrl: './brackets-tester.component.html',
  styleUrls: ['./brackets-tester.component.css']
})
export class BracketsTesterComponent implements OnInit {
  
  textEntry = '';
  public testResults: TestResult[] = [];

  constructor(private bracketsService: BracketsService) { }

  ngOnInit(): void {
    // Run Some Examples
    this.textEntry = "{hi}";
    this.testBrackets();
    
    this.textEntry = "[()}";
    this.testBrackets();

    this.textEntry = "[{as}(12)]";
    this.testBrackets();

    this.textEntry = "(only)[{1}({})]";
    this.testBrackets();

    this.textEntry = "([((({()})))])";
    this.testBrackets();

    this.textEntry = "([((({()}))))";
    this.testBrackets();
  }

  testBrackets() {

    const result = this.bracketsService.MatchBrackets(this.textEntry);
    this.testResults.push(new TestResult(this.textEntry, result));
    this.textEntry = '';
  }
}
