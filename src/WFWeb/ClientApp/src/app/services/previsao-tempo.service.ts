import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BaseService } from './base.service';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class PrevisaoTempoService extends BaseService {

  constructor(private httpClient: HttpClient,
    @Inject('BASE_URL') private baseUrl: string) {
    super();
    this.baseUrl += 'previsaotempo/';
  }

  public getCidades(nomeCidade: string): Observable<any[]> {
    return (
      this.httpClient.get<any[]>
        (this.baseUrl + 'nomecidade/' + nomeCidade, super.httpOptions)
        .pipe(catchError(super.handleError))
    );
  }

  public GetPrevisao7Dias(cidade: any): Observable<any> {
    return (
      this.httpClient.get<any[]>
        (this.baseUrl + cidade.id, super.httpOptions)
        .pipe(catchError(super.handleError))
    );
  }

}
