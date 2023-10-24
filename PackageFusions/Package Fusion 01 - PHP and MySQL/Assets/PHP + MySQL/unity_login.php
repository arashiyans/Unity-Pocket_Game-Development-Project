<?php
	$connect = mysql_connect("localhost","root","");
	$database = mysql_select_db("db_unity");
	if (!$connect && !$database){
		die ("Cant Connect To Host / Database Not Found!");
	}
	$username = $_POST['unity_user'];
	$password = $_POST['unity_pass'];
	
	$sql = "SELECT * FROM tb_login WHERE username = '$username' AND password = '$password' ";
	$result = mysql_query($sql);
	$row = mysql_fetch_row($result);
	if ($row[2]){
		echo $row[2];
	} else {
		echo "INVALID";
	}
?>