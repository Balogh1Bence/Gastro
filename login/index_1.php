<?php
session_start();    
require_once('config/connect.php');
if (isset($_SESSION['uid'])){
    //Belépve
    $menu = file_get_contents('html/menu_in.html');
} else {
    //Nincs belépve
    $menu = file_get_contents('html/menu_out.html');
}

$sql = "SELECT * FROM termekek";
$res = $conn -> query($sql);
$numRows = $res -> num_rows;

$numPages = ceil($numRows / 20);
$oldalak = "";
for ($i = 1; $i<= $numPages; $i++){
    $oldalak .= "<a href='index.php?page={$i}'>{$i}</a>";
}
if (isset($_GET['page'])){
    $page = $_GET['page'];
} else {
    $page = 1;
}
if ($page > 9) {  $page = 9; }
if ($page < 1) {  $page = 1; }

if (isset($_GET['filter'])){
    $productNum = $_GET['productNumber'];
    
} else {
    $productNum = 20;
}

$record = ($page-1) * 20;
$sql = "SELECT * FROM termekek ";
if ($productNum != "mind"){
     $sql .= "LIMIT $record, $productNum";
}
$res = $conn -> query($sql);

$tabla = "";
if ($res){
    $tabla = "<table id='termekek'>"
            . "<tr>"
            . "<td>ID</td>"
            . "<td>Megnevezés</td>"
            . "<td>Feszültség</td>"
            . "<td>Teljesítmény</td>"
            . "<td>Foglalat</td>"
            . "<td>Élettartam</td>"
            . "<td>Ár</td>"
            . "</tr>";
    
    while ($row = $res -> fetch_array()){
        $tabla .= "<tr>"
                . "<td>{$row[0]}</td>"
                . "<td>{$row[2]}</td>"
                . "<td>{$row[3]}</td>"
                . "<td>{$row[4]}</td>"
                . "<td>{$row[5]}</td>"
                . "<td>{$row[6]}</td>"
                . "<td>{$row[7]}</td>"
                . "</tr>";
    }
    $tabla .= "</table>";
}

?>
<!DOCTYPE html>

<html>
    <head>
        <meta charset="UTF-8">
        <title>Login</title>
        <link rel="stylesheet" type="text/css" href="css/style.css">
    </head>
    <body>
        <nav>
            <?php echo $menu; ?>
        </nav>
        <div id="tartalom">
            <?php 
                echo $oldalak;
                echo $tabla;
                echo file_get_contents('html/filter.html');
            ?>
        </div>
        <?php
            if (isset($_SESSION['uid'])){
                $sql = "SELECT username FROM user WHERE uid = '{$_SESSION['uid']}'";
                $res = $conn -> query($sql);
                if ($res){
                    $row = $res -> fetch_row();
                    //echo "Szép napot kedves ".$row[0];
                }
                
            }
        ?>
    </body>
</html>
