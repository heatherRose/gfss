import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BracketsService {

  private bracketChars: [string, string][] = [['{','}'],['[',']'],['(',')']];

  constructor() { }

  public MatchBrackets(s:string): boolean {
      // Check if the string is of length 1. If so, check if it is one of the bracket characters.
      if (s.length == 1) return !this.isBracketChar(s);

      console.log(`Inside Brackets Service. Testing : ${s}`);
      const recurved = this.propagatingBracketMatch(s, '');
      console.log(recurved);
      return recurved[1];
  }

  private propagatingBracketMatch(s: string, closing: string): [rem: string, closes: boolean]
  {    
    if (!s || s == '') return ['', true];

    console.log(`String: ${s}, Closing: ${closing}`);

    if (s.length == 1) return ['', s == closing || !this.isBracketChar(s)];

    var first = s[0];
    var clipped = this.clipFirst(s);

    if(first == closing) return [clipped, true];
    
    const isBracket = this.isBracketChar(first);
    const newClosing = this.findClosing(first);
    const isOpeningBrack = isBracket && newClosing !== '';

    let recurved = ['',true];

    if(!isBracket) {
      return this.propagatingBracketMatch(clipped, closing);
    }

    if(isOpeningBrack) {
      const recurved = this.propagatingBracketMatch(clipped, newClosing);
      if(recurved[1] == false) return ['', false];

      return this.propagatingBracketMatch(recurved[0], closing);
    }
    
    return ['', false];
  }

  private isBracketChar(s: string): boolean {
      return this.bracketChars.some(tup => tup[0] == s || tup[1]== s);
  }
  
  private findClosing(opening: string): string {
      var openingTuple = this.bracketChars.find(tup => tup[0] == opening);

      if(!openingTuple) return '';

      return openingTuple[1];
  }

  private clipFirst(s: string): string {
    return s.slice(1, s.length);
  }
}
