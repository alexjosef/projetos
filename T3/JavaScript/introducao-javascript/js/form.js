var botaoAddPaciente = document.querySelector("#adicionar-paciente");
botaoAddPaciente.addEventListener("click", function(event) {
  event.preventDefault();

  var form = document.querySelector("#form-adiciona");

  var paciente = obtemPacienteDoForm(form);

  var erros = validaPaciente(paciente);

  if (erros.length > 0) {
    exibeMensagensDeErro(erros);
    return;
  }

  adicionaPacienteNaTabela(paciente);

  form.reset();
  var mensagemErro = document.querySelector("#mensagens-erro")
  mensagemErro.innerHTML = "";

});

function adicionaPacienteNaTabela(paciente) {
    var pacienteTr = montaTr(paciente);
    var tabela = document.querySelector("#tabela-pacientes");
    tabela.appendChild(pacienteTr);
}

function obtemPacienteDoForm(form){
  paciente = {
    nome: form.nome.value,
    peso: form.peso.value,
    altura: form.altura.value,
    gordura: form.gordura.value,
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

function validaPaciente(paciente){

  var erros = [];

  if (paciente.nome.length == 0){
    erros.push("Campo nome obrigatório!");
  }

  if (paciente.peso.length == 0){
    erros.push("Campo peso obrigatório!");
  }

  if (paciente.altura.length == 0){
    erros.push("Campo altura obrigatório!");
  }

  if (paciente.gordura.length == 0){
    erros.push("Campo gordura obrigatório!");
  }

    if (!validaPeso(paciente.peso)){
      erros.push("Peso inválido");
  }

  if (!validaAltura(paciente.altura)){
    erros.push("Altura inválida");
  }
  return erros;
}

function exibeMensagensDeErro(erros){
  var ul = document.querySelector("#mensagens-erro");
  ul.innerHTML = "";

  erros.forEach(function(erro){
    var li = document.createElement("li");
    li.textContent = erro;
    ul.appendChild(li);
  });
}
