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

$sql = "SELECT password from users WHERE username = '" . $loginUser . " '";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
        if($row["password"]==$loginPassword){
            echo "Login Success.";
            //Get User's data 

            //Get Player Info.

            //Modify Player Data.

            //Update invenetory.
            
        }
            else{
                echo "Wrong Credential.";
            }
    }
} else {
    echo "Username doen not exits.";
}
$conn->close();

?>