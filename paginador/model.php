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

    $k = 0;
    for($i=$data; $i<$total+1; $i++){
        $k++;
        $res[6][$k] = $i;
    }

    $res[7] = $total - $data;

    echo json_encode($res);
?>