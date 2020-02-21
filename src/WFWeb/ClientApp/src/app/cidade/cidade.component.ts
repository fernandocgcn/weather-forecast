import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { FormControl } from '@angular/forms';
import { PrevisaoTempoService } from '../services/previsao-tempo.service';

@Component({
  selector: 'cidade',
  templateUrl: './cidade.component.html'
})
export class CidadeComponent implements OnInit {
  public myControl = new FormControl();
  public cidades: any[];
  @Output() public cidade = new EventEmitter();

  constructor(private previsaoTempoService: PrevisaoTempoService) { }

  public ngOnInit(): void {
    this.myControl.valueChanges.subscribe(data => this.filter(data));
  }

  public displayFn(cidade: any): string {
    return cidade && cidade.nome ? cidade.nome : '';
  }

  private filter(nomeCidade: string): void {
    this.previsaoTempoService.getCidades(nomeCidade)
      .subscribe(
        result => this.cidades = result,
        errorMessage => alert(errorMessage)
    );
  }

  public updatePrevisaoForm(cidade: any): void {
    this.cidade.emit(cidade);
  }
}
