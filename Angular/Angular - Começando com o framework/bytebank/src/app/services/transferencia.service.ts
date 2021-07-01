import { Injectable } from "@angular/core";
import {HttpClient} from "@angular/common/http";
import { Transferencia } from "../models/transferencia.models";
import { Observable } from "rxjs/internal/Observable";

@Injectable({
  providedIn: "root"
})
export class TransferenciaService {

  private listaTransferencia: any[];
  private url = "http://localhost:3000/transferencias";

  constructor(private httpClient: HttpClient) {
    this.listaTransferencia = [];
  }

  get transferencias(): any[] {
    return this.listaTransferencia;
  }

  todas(): Observable<Transferencia[]> {
    return this.httpClient.get<Transferencia[]>(this.url);
  }

  adicionar(transferencia: Transferencia): Observable<Transferencia> {
    this.hidratar(transferencia);

    return this.httpClient.post<Transferencia>(this.url, transferencia);
  }

  private hidratar(transferencia: any): void {
    transferencia.data = new Date();
  }

}
