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

        <div class="content">
            <div class="container-fluid">
                
            <div class="row">
                <div class="col-md-12">
                    <div class="card">
                        <div class="header">
                            <p>INFORMATIONS:</p>
                        </div>
                        <div class="content">
                            <h4>1. WHAT IS LANDSLIDE?</h4>
                            <div>
                                Landslides are one of the greatest hazards of the world. A landslide is the movement of rock, debris or earth down a slope. They result from the failure of the materials which make up the hill slope and are driven by the force of gravity. The speed of movement of the falling soil can vary. The sudden rapid events are much more dangerous than the slow gradual slides. And therefore, landslides have caused numerous fatalities, environmental degradation and millions of dollars damage to buildings, roads, railways, pipelines, communication networks and agricultural land, or for the record, more than 11.500 fatalities in 70 countries between 2007-2010.
                            </div>

                            <h4>2. WHAT IS THE MAIN PROBLEM?</h4>
                            <div>
                                Some of the factors that cause landslides are rainfalls, floods. But these components, as natural phenomenas aren't predictible with 100% accuracy, so consecutively landslides can't be predicted. So, it follows that the inability of the landslides to be predicted is the main problem.
                            </div>
                            <h4>3. HOW DO WE FIX THE PROBLEM?</h4>
                            <div>
                                Our soulution of the problem is based on prediction whether landslides are likely to occur. Intensity-duration thresholds, in combination with rainfall forecasts and real-time rainfall measurements, have been the basis for operational landslide warning systems in several areas. Therefore, by providing the landslides' prediction, people can be informed about the possible danger and prevent the damages that may occur.
                            </div>
                            <h4>4. WHAT IS OUR TOOL?</h4>
                            <div>
                                We have designed a tool that can be used by anyone who would like to check whether he/she is safe, including the construction workers, civil engineers, agricultural engineers, tourists and many more. The web application can use your current geolocation and give you information about the safety of the location, or it can let you add some other location and get all the information related to it, including weather forecast, which affects the possibility of landslides and list of previous occured landslides. The desktop application uses the same input information, and displays the previous landslides on radius of 250 km of the center of the given country.
                            </div>
                            <h4>5. WHAT WE PLAN FOR FUTURE UPGRADING?</h4>
                            <div>
                                Our aim for the future development of our tool is to include even more features that will be used for more precise predictions.
                            </div>
                            <h4>6. TEAM</h4>
                            <div>
                                The team B.I.S.Y. was formed just few days before the begining of the hackathon NASA Space Apps Challenge and resulted with unbelievable good collaboration among the young software developers with bright future.
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="card">
                    <div class="header text-center">
                        <h4 class="title">STATISTICS OF LANDSLIDE CAUSES</h4>
                        
                    </div>
                    <div class="content">
                        <div id="chartPreferences" class="ct-chart ct-perfect-fourth"></div>

                        <div class="footer text-center">
                            <div class="legend">
                                <i class="fa fa-circle text-info"></i> Rain 
                                <i class="fa fa-circle text-danger"></i> Continous_rain
                                <i class="fa fa-circle text-warning"></i> Downpoor
                                <i class="fa fa-circle " style="color: #5e5e5e;"></i> Other factors 
                                <i class="fa fa-circle " style="color: #1F77D0;"></i> Unknown factors
                                <i class="fa fa-circle " style="color: #87CB16;"></i> Tropical_Cyclone
                                <i class="fa fa-circle " style="color: #9368E9;"></i> Monsoon
                            </div>
                            <hr>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

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

<script type="text/javascript">
           $(document).ready(function(){

            demo.initChartist();


            });
       </script>

</html>