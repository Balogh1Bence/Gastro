<?php
session_start();
require_once('../config/connect.php');
require_once('../config/functions.php');

if (isset($_POST['belep'])){
    $userName = $_POST['username'];
    $pwd = $_POST['password'];
    $sql = "SELECT * FROM user WHERE username = '$userName' AND password = '$pwd'";
    $res = $conn -> query($sql);
    
    if ($res) {
        if ($res -> num_rows == 1){
            //belépett
            $row = $res -> fetch_row();
            $_SESSION['uid'] = $row[0];
        } else {
            //érvénytelen belépés
            $_SESSION['error'] = 'Helytelen felhasználónév vagy jelszó!';
        }
    }
    header('Location: ../index.php');
}

