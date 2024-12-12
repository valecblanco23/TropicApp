document.addEventListener('DOMContentLoaded', function () {
    const barraBusqueda = document.getElementById('barraBusqueda');
    const tarjetas = document.querySelectorAll('#servicios .col-md-4');

    barraBusqueda.addEventListener('input', function (evento) {
        const consulta = evento.target.value.toLowerCase();

        tarjetas.forEach(tarjeta => {
            const contenidoTexto = tarjeta.textContent.toLowerCase();
            if (contenidoTexto.includes(consulta)) {
                tarjeta.style.display = 'block';
            } else {
                tarjeta.style.display = 'none';
            }
        });
    });
});
