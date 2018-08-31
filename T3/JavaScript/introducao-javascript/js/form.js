var botaoAddPaciente = document.querySelector("#adicionar-paciente");
botaoAddPaciente.addEventListener("click", function(event) {
  event.preventDefault();

  var form = document.querySelector("#form-adiciona");

  var paciente = obtemPacienteDoForm(form);

  var pacienteTr = montaTr(paciente)

  var tabelaPacientes = document.querySelector("#tabela-pacientes");

  tabelaPacientes.appendChild(pacienteTr);

  form.reset();

});

function obtemPacienteDoForm(form){
  paciente = {
    nome: form.nome.value,
    peso: form.peso.value,
    altura: form.altura.value,
    gordura: form.gordura.value
    imc: calculaImc(form.peso.value, form.altura.value)
  }
  return paciente;
}

function montaTd(dado, classe){
  var td = document.createElement("td");
  td.classList.add(classe);
  td.textContent = dado;

  return td;
}

function montaTr(paciente){
  var pacienteTr = document.createElement("tr")

  pacienteTr.appendChild(montaTd(paciente.nome, "info-nome"));
  pacienteTr.appendChild(montaTd(paciente.peso, "info-peso"));
  pacienteTr.appendChild(montaTd(paciente.altura, "info-altura"));
  pacienteTr.appendChild(montaTd(paciente.gordura, "info-gordura"));
  pacienteTr.appendChild(montaTd(paciente.imc, "info-imc"));

  return pacienteTr;
}
