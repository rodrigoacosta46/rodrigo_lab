<?php
    define('REGISA', 5);
    
    $conn = mysqli_connect('localhost', 'root', '', 'db');

    $data = intval($_GET['page']);

    $from = REGISA * ($data - 1);

    
    $sql = "SELECT * FROM rangos";

    $query = mysqli_query($conn, $sql);

    $total = mysqli_num_rows($query);


    $sql .= " LIMIT ".$from.",".REGISA;

    $qry = mysqli_query($conn, $sql);

    $res = mysqli_fetch_all($qry);

    $total = ceil($total / REGISA);

    $res[6] = $total;

    echo json_encode($res);
?>