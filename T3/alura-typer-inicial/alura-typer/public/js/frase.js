
$("#botao-frase".click(fraseAleatoria);



//Buscando Frases no servidor
function fraseAleatoria() {
    $.get("http://localhost:3000/frases", function(data){
        var frase = $(".frase");
    });
}