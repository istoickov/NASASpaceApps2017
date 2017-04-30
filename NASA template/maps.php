<?php
    include("head.php");
?>

<title>When Landslides Strike - B.I.S.Y.</title>
</head>
<body>

<div class="wrapper">
     <?php
        include("sidebar.php");
    ?>

    <div class="main-panel">
    <?php
            include("header.php");
        ?>
		
        <div class="row">
            <div class="col-md-12 text-left">
                <div class="form-group">
                    <br>
                    <input type="text" name="location" id="enterLoc" class="form-control" placeholder="Enter location" value="">
                </div>
            </div>
        </div>

        <div class="row">
          <div class="col-md-3 col-md-offset-3 btnSearch">
              <button type="button" id="btnSearchAddress" onclick="demo.initGoogleMaps(getElementById('enterLoc').value, null)" class="btn btn-info btn-fill stotka">Search</button>
          </div>
          <div class="col-md-3">
              <button type="button" onclick="demo.initGoogleMaps(null, null)" class="btn btn-success btn-fill stotka">Find my location</button>
          </div>
        </div>
        <br>
        <div id="map">
            
        </div>

    </div>
</div>


</body>

        <!--   Core JS Files   -->
    <script src="assets/js/jquery-1.10.2.js" type="text/javascript"></script>
	<script src="assets/js/bootstrap.min.js" type="text/javascript"></script>

	<!--  Checkbox, Radio & Switch Plugins -->
	<script src="assets/js/bootstrap-checkbox-radio-switch.js"></script>

	<!--  Charts Plugin -->
	<script src="assets/js/chartist.min.js"></script>

    <!--  Notifications Plugin    -->
    <script src="assets/js/bootstrap-notify.js"></script>

    <!--  Google Maps Plugin    -->
    <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAv5mePWBs5PRYlEVVMBD4fHFA45Sk0Iu4"></script>

    <!-- Light Bootstrap Table Core javascript and methods for Demo purpose -->
	<script src="assets/js/light-bootstrap-dashboard.js"></script>

	<!-- Light Bootstrap Table DEMO methods, don't include it in your project! -->
	<script src="assets/js/demo.js"></script>
<script type="text/javascript" src="function.js"></script>
    <script>
        $().ready(function(){
            demo.initMap();
        });


        
    </script>

</html>
