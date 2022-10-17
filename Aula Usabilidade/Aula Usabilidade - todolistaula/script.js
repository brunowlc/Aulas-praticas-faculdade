let newtarefa = document.getElementById('newtarefa');
let botao = document.getElementById('botao');
let ul = document.getElementById('lista');
let mensagem = document.getElementById('mensagem');
let botao2 = document.getElementById('botao2');


botao.addEventListener('click', () => {

    if (isNaN(newtarefa.value)) {
        let li = document.createElement('li');
        let liText = document.createTextNode(newtarefa.value)
        li.appendChild(liText);
        ul.appendChild(li);
        mensagem.innerHTML = "";
    } else (
        mensagem.innerHTML = " Tarefa em branco, não poooode "
    )
    newtarefa.value = "";
})

botao2.addEventListener('click', () => {

    if (isNaN(lista.value)) {
        let ul = document.getElementById('lista');
        ul.remove();
    }
})