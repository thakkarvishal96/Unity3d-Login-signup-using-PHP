<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "unity";

//variable submitted by user 
$loginUser = $_POST["loginUser"];
$loginPassword = $_POST["loginPass"];

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$sql = "SELECT username from users WHERE username = '" . $loginUser . " '";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    //tell user that name is already taken 
    echo "Username is already taken.";
}
 else {
    echo "Creating user..";
    //insert username and password into database 
    $sql2 = "INSERT INTO users (username, password) VALUES ('" . $loginUser . " ','" . $loginPassword . " ')";
    if ($conn->query($sql2) === TRUE) {
        echo "New record created successfully";
    } else {
        echo "Error: " . $sql2 . "<br>" . $conn->error;
    }
}
$conn->close();

?>