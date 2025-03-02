function copyToClipboard(text) {
    navigator.clipboard.writeText(text).then(function() {
        console.log("Senha copiada com sucesso!");
    }).catch(function(err) {
        console.error("Erro ao copiar: ", err);
    });
}