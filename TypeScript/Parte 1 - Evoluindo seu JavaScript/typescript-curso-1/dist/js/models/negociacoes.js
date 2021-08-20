export class Negociacoes {
    constructor() {
        this.negociacoes = Array();
    }
    adiciona(negociacao) {
        this.negociacoes.push(negociacao);
    }
    lista() {
        return this.negociacoes;
    }
}
