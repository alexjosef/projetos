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
    var imc = peso / (altura * altura);
    paciente.querySelector(".info-imc").textContent = imc.toFixed(2);
  }
}

var botaoAddPaciente = document.querySelector("#adicionar-paciente");
botaoAddPaciente.addEventListener("click", function(event) {
  event.preventDefault();

  var form = document.querySelector("#form-adiciona");

  var nome = form.nome.value;
  var peso = form.peso.value;
  var altura = form.altura.value;
  var gordura = form.gordura.value;

  var pacienteTr = document.createElement("tr");

  var nomeTd = document.createElement("td");
  var pesoTd = document.createElement("td");
  var alturaTd = document.createElement("td");
  var gorduraTd = document.createElement("td");

  nomeTd.textContent = nome;
  pesoTd.textContent = peso;
  alturaTd.textContent = altura;
  gorduraTd.textContent = gordura;

  pacienteTr.appendChild(nomeTd);
  pacienteTr.appendChild(pesoTd);
  pacienteTr.appendChild(alturaTd);
  pacienteTr.appendChild(gorduraTd);

  var tabelaPacientes = document.querySelector("#tabela-pacientes");

  tabelaPacientes.appendChild(pacienteTr);
});
