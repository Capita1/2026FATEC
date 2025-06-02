<?php
	session_start();

	//Limpar toda a SESSAO
	session_destroy();

	header("Location:index.php");
?>