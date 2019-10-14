import { TestBed, inject } from '@angular/core/testing';

import { DisplaySuggestionService } from './display-suggestion.service';

describe('DisplaySuggestionService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [DisplaySuggestionService]
    });
  });

  it('should be created', inject([DisplaySuggestionService], (service: DisplaySuggestionService) => {
    expect(service).toBeTruthy();
  }));
});
