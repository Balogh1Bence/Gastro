<?php
session_start();
require_once('../config/connect.php');
require_once('../config/functions.php');

if (isset($_POST['belep'])){
    $userName = $_POST['username'];
    $pwd = $_POST['password'];
    $sql = "SELECT * FROM user WHERE username = '$userName'";
    $res = $conn -> query($sql);
    
    if ($res) {
		$row = $res -> fetch_row();
		$hash=$row[2];
		
		
        if (password_verify($pwd,$hash)){
            //belépett
            
            $_SESSION['uid'] = $row[0];
        } else {
            //érvénytelen belépés
            $_SESSION['error'] = 'Helytelen felhasználónév vagy jelszó!';
        }
    }
    header('Location: ../index.php');
}

