var titulo = document.querySelector(".titulo");
titulo.textContent = "Aparecida Nutricionista";

var pacientes = document.querySelectorAll(".paciente");

for(i = 0 ; i < pacientes.length; i++){
  var paciente = pacientes[i]

  var peso = paciente.querySelector(".info-peso").textContent;
  var altura = paciente.querySelector(".info-altura").textContent;

  var pesoEhValido = validaPeso(peso)
  var alturaEhValido = validaAltura(altura)

  if (!pesoEhValido){
    paciente.querySelector(".info-imc").textContent = "Peso inválido!";
    paciente.classList.add("paciente-invalido");
  }
  if(!alturaEhValido){
    paciente.querySelector(".info-imc").textContent = "Altura inválida!";
    paciente.classList.add("paciente-invalido");
  }
  if(pesoEhValido && alturaEhValido){
    imc = calculaImc(peso, altura)
    paciente.querySelector(".info-imc").textContent = imc;
  }
}

function calculaImc(peso, altura){
  var imc = 0;
  imc = peso / (altura * altura);
  return imc.toFixed(2);
}

function validaPeso(peso){
  if(peso > 0 && peso < 1000){
    return true;
  }else{
    return false;
  }
}

function validaAltura(altura){
  if (altura > 0 && altura < 3.00){
    return true;
  }else{
    return false;
  }
}
