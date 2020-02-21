import { Component, Directive } from '@angular/core';
import { PrevisaoTempoService } from '../services/previsao-tempo.service';

@Component({
  selector: 'previsao',
  templateUrl: './previsao.component.html'
})
@Directive({ selector: 'previsao' })
export class PrevisaoComponent {

  public previsaoCidade: any;
  public displayedColumns: string[] =
    ['dataDia', 'tempo', 'maxima', 'minima'];

  constructor(private previsaoTempoService: PrevisaoTempoService) { }

  public updateCidade(cidade: any): void {
    this.previsaoTempoService.GetPrevisao7Dias(cidade)
      .subscribe(
        result => this.previsaoCidade = result,
        errorMessage => alert(errorMessage)
    );
  }

}
