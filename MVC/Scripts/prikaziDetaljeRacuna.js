function prikaziDetaljeRacuna(id) {
    var url = "/Home/DohvatiSvePodatkeRacuna";
    $.get(url, { id: id })
        .done(function (response) {
            $("#detaljiRacuna").html(response);
        });
}