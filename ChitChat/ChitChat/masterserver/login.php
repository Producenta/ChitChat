<?php
include "config.php";
/* 
ChitChat MasterServer

Functions to login the user:
*/

if (isset($_POST['username'])) {
	//Assing variables sent from the program
	$username = 		mysql_real_escape_string($_POST['username']);
	$password = 		mysql_real_escape_string($_POST['password']);

	$conn = mysql_connect(DB_HOST, DB_USER, DB_PASS);

	if ($conn) {
		$select_db = mysql_select_db(DB_NAME, $conn);

		if ($select_db) {
			$sql  = "SELECT * FROM users WHERE username = '{$username}' AND password = '{$password}'";
		
			$result = mysql_query($sql, $conn);
			if($result) // If executed successfuly
			{
				if (mysql_num_rows($result) >= 1) 
				{	
					$info = mysql_fetch_array($result);
					echo "true";
					echo "<sep>id={$info['id']}";
					echo "<sep>username={$info['username']}";
					echo "<sep>email={$info['email']}";
					echo "<sep>joinDate={$info['joinDate']}";
					echo "<sep>country={$info['country']}";
					echo "<sep>nation={$info['nation']}";
					echo "<sep>language={$info['language']}";
					echo "<sep>phone={$info['phone']}";
					echo "<sep>sex={$info['sex']}";
					echo "<sep>name={$info['name']}";
					echo "<sep>city={$info['city']}";
					echo "<sep>onlineStance={$info['onlineStance']}";
					echo "<sep>isDonator={$info['isDonator']}";
					echo "<sep>info={$info['info']}";
				}
				else 
				{
					echo "false";
				}
			}
		}
		else {
			die("Cannot select database!<br />" . mysql_error());
		}
	}
	else {
		die("Cannot connect to database!<br />" . mysql_error());
	}
}
else {
	echo "<h1>Sorry, you have no place here :)</h1>";
}