var titulo = document.querySelector(".titulo");
titulo.textContent = "Aparecida Nutricionista";

var pacientes = document.querySelectorAll(".paciente");

for(i = 0 ; i < pacientes.length; i++){
  var paciente = pacientes[i]

  var peso = paciente.querySelector(".info-peso").textContent;
  var altura = paciente.querySelector(".info-altura").textContent;

  if (peso <= 0 || peso >= 1000){
    paciente.querySelector(".info-imc").textContent = "Peso inválido!";
    paciente.classList.add("paciente-invalido");
  }
  else if(altura <= 0 || altura >= 4.00){
    paciente.querySelector(".info-imc").textContent = "Altura inválida!";
    paciente.classList.add("paciente-invalido");
  }
  else{
    var imc = calculaImc(peso, altura)
    paciente.querySelector(".info-imc").textContent = imc;
  }
}

function calculaImc(peso, altura){
  var imc = 0;
  imc = peso / (altura * altura);
  return imc.toFixed(2);
}
