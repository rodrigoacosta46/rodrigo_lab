<?php
    $conn = mysqli_connect('localhost', 'root', '', 'db');

    $datos[0][0] = 'Pusilanime';
    $datos[0][1] = 'Coronel';
    $datos[0][2] = 'Sargento';
    $datos[0][3] = 'Encargado';
    $datos[0][4] = 'Comandante';

    $datos[1][0] = 'Naval';
    $datos[1][1] = 'Aerea';
    $datos[1][2] = 'Tedax';
    $datos[1][3] = 'Terrestre';
    $datos[1][4] = 'Comunicaciones';

    $datos[2][0] = 'Oficial';
    $datos[2][1] = 'Suboficial';
    
    $query = mysqli_query($conn, "INSERT INTO rangos VALUES (null, '".$datos[0][rand(0,4)]."', '".$datos[1][rand(0,4)]."', '".$datos[2][rand(0,1)]."')");

    if(!$query){
        die('Error de Consulta' . mysqli_error($conn));
    }
?>