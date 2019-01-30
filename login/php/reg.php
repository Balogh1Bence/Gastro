<?php
    session_start();
    require_once("../config/connect.php");
    if (!isset($_POST["reg"])){
        die();
    } 
    $user = trim($_POST["user"]);
    $pwd = trim($_POST["pwd"]);
    $pwdc = trim($_POST["pwdc"]);
    if (($pwd == $pwdc) && ($user != $pwd) && (strlen($user) > 5 ) && (strlen($pwd) > 5)){
       
        $hash = password_hash($pwd, PASSWORD_DEFAULT);
     $sql = "INSERT INTO user (username,password,reg_date,active) VALUES ('$user', '$hash',CURDATE(),1)";
		if ($conn->query($sql) === TRUE) {
    echo "New record created successfully";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

        
    }

