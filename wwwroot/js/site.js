function MostrarTemporadas(id){
$.ajax(
    {
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/VerDetalleTemporadas',
        data: {IdSerie: id},
        success:
        function (response)
        {
            $("#titulo").html("Temporadas:");
            let texto = "";
            for(let item of response){
                texto += (item.numeroTemporada+ ". "+item.tituloTemporada + "<br>") ;
            }
            $("#informacion").html(texto)
        }
    });
}
function MostrarActores(id){
    
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerDetalleActores',
            data: {IdSerie: id},
            success:
            function (response)
            {
                $("#titulo").html("Actores:");
                let texto = "";
                for(let item of response){
                    texto += item.nombre + "<br>";
                }
                $("#informacion").html(texto)
            }
        });
    }

    function MostrarInfo(id){
    
        $.ajax(
            {
                type: 'POST',
                dataType: 'JSON',
                url: '/Home/VerDetalleInfo',
                data: {IdSerie: id},
                success:
                function (response)
                {
                    console.log("r");
                    $("#titulo").html("Info:");
                    $("#informacion").html(response)
                }
            });
        }