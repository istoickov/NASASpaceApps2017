<?php
include ("head.php");
?>

<title>When Landslides Strike - B.I.S.Y.</title>
</head>
<body>

<div class="wrapper">
    <?php
        include("sidebar.php");
        $isHidden = "hidden";
        $lat = "";
        $lng = "";
        $long_name = "";
    ?>
    <div class="main-panel">
        

        <?php
            include("header.php");
        ?>
        <div class="content">
            <div class="container-fluid">
                <div class="row text-center">
                    <h4 class="title">PERCENTAGE FOR LANDSLIDES CAUSES:</h4>
                </div>
                <br>
                <div class="row">
                    <div class="col-md-12">
                        <div class="row text-center">
                            <!-- <img src="assets/img/faces/face-0.jpg" class="img-circle"> -->

                            
                            <div class="col-md-4 col-sm-4 col-xs-4">
                                <div id="container2"></div>
                                <br>
                                <p class="progressText">TROPICAL CYCLONE</p>
                            </div>
                            <div class="col-md-4 col-sm-4 col-xs-4" >
                                <div id="container"></div>
                                <br>
                                <p class="progressText">RAIN</p>
                            </div>
                            <div class="col-md-4 col-sm-4 col-xs-4">
                                <div id="container3"></div>
                                <br>
                                <p class="progressText">MONSOON</p>
                            </div>

                        </div>
                        
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
                              <button type="button" id="btnSearchAddress" class="btn btn-info btn-fill stotka">Search</button>
                          </div>
                          <div class="col-md-3">
                              <button type="button" onclick="getLocation()" class="btn btn-success btn-fill stotka">Find my location</button>
                          </div>
                        </div>
            
                    </div>
                </div>
                <br>                
                <div id="infoLog" class='row' ?>
                    <div class="col-md-12">
                        <div class="card">
                            <div class="header">
                                <h4 class="title">Your location is:</h4>
                                <br>
                                <p id="adr"></p>
                                <p id="lat"></p>
                                <p id="lng"></p>
                                
                            </div>

                            <!-- nav kopchinja za weather i landslides -->

                            <div class="row col-md-12 text-center">
                              <div class="col-md-6 text-left">
                                <button type="button"class="btn btn-info btn-fill stotka" id="btnWeat">WEATHER</button>
                              </div>
                              <div class="col-md-6 text-right">
                                <button type="button"class="btn btn-warning btn-fill stotka" id="btnLand">LANDSLIDES</button>
                              </div>
                            </div>
                            
                            <div class="content cont-weather">
                          
                            <br>
                            <br>
                                
                                <div class="alert alert-info ">
                                <div class="text-center">
                                  <h4 class="title">WEATHER</h4>
                                </div> 
                                    <div id="points"></div>
                                    <div id="wheater">
                                      <div id="history"></div>
                                      <div id="forecast"></div>
                                    </div>
                                </div>
                            </div>

                            <div class="content">
                            <br>
                            <br>
                                
                                <div class="alert alert-warning cont-landslide">
                                <div class="text-center">
                                  <h4 class="title">LANDSLIDE</h4>
                                </div> 
                                
                                </div>
                                
                            </div>


                        </div>
                    </div>
                </div>
            </div>
        </div>

        <?php 
            include("footer.php");
        ?>


  <script type="text/javascript">
                    var la = document.getElementById("lat");
                    var ln = document.getElementById("lng");
                    var ad = document.getElementById("adr");
                    function getLocation() {
                      $(".cont-landslide").html('<div class="text-center"><h4 class="title">LANDSLIDE</h4></div>');
                      $("#history").html("<h2>Last 30 days:</h2>");
                      $("#forecast").html("<h2>Next 10 days: </h2>");
                        if (navigator.geolocation) {
                            navigator.geolocation.getCurrentPosition(showPosition);
                        } else {
                            ad.innerHTML += "Geolocation is not supported by this browser.";
                        }
                    }
                    function showPosition(position) {
                      var lat = position.coords.latitude;
                      var lng = position.coords.longitude

                      landslideZone(lng,lat);
                      wheaterPredict(lat,lng);
                      findLandslides(lat,lng);
                        la.innerHTML = "Latitude: " + lat;
                        ln.innerHTML ="Longitude: " + lng;
                        $.ajax({
                          url: "https://maps.googleapis.com/maps/api/geocode/json?latlng=" + lat + "," + lng + "&key=AIzaSyAv5mePWBs5PRYlEVVMBD4fHFA45Sk0Iu4"
                        })
                          .done(function( data ) {
                            var adress = data['results'][0]['formatted_address'];
                            ad.innerHTML = "Address: " + adress;
                            $("#infoLog").show("slow");

                          });
                        
                    }
                    $("#btnSearchAddress").click(function() {

                      $("#history").html("<h2>Last 30 days:</h2>");
                      $("#forecast").html("<h2>Next 10 days: </h2>");
                      $(".cont-landslide").html('<div class="text-center"><h4 class="title">LANDSLIDE</h4></div>');
                      var addr = $("#enterLoc").val();
                      if(addr.length > 0){
                         $.ajax({
                            url: "https://maps.googleapis.com/maps/api/geocode/json?address=" + addr + "&key=AIzaSyAv5mePWBs5PRYlEVVMBD4fHFA45Sk0Iu4"
                          })
                            .done(function(data) {
                              var adress = data['results'][0]['formatted_address'];
                              var lat = data['results'][0]['geometry']['location']['lat'];
                              var lng = data['results'][0]['geometry']['location']['lng'];

                              wheaterPredict(lat,lng);
                              findLandslides(lat,lng);
                              landslideZone(lng,lat);
                              ad.innerHTML = "Address: " + adress;
                              la.innerHTML = "Latitude: " + lat;
                              ln.innerHTML = "Longitude " + lng;
                              $("#infoLog").show("slow");

                            });

                        }
                    });
      $(document).ready(function(){

          // demo.initChartist();

          // $.notify({
         //     icon: 'pe-7s-gift',
         //     message: "Welcome to <b>Light Bootstrap Dashboard</b> - a beautiful freebie for every web developer."

         //    },{
         //        type: 'info',
         //        timer: 4000
         //    });

      });
        // progressbar.js@1.0.0 version is used
// Docs: http://progressbarjs.readthedocs.org/en/1.0.0/

var bar = new ProgressBar.Circle(container, {
  color: '#aaa',
  // This has to be the same size as the maximum width to
  // prevent clipping
  strokeWidth: 10,
  trailWidth: 10,
  easing: 'easeInOut',
  duration: 1400,
  text: {
    autoStyleContainer: false
  },
  from: { color: '#88c140', width: 10 },
  to: { color: '#88c140', width: 10 },
  // Set default step function for all animate calls
  step: function(state, circle) {
    circle.path.setAttribute('stroke', state.color);
    circle.path.setAttribute('stroke-width', state.width);

    var value = Math.round(circle.value() * 100);
    if (value === 0) {
      circle.setText('');
    } else {
      circle.setText(value + "%");
    }

  }
});
bar.text.style.fontFamily = '"Raleway", Helvetica, sans-serif';
bar.text.style.fontSize = '4rem';

bar.animate(0.73);  // Number from 0.0 to 1.0

var bar2 = new ProgressBar.Circle("#container2", {
  color: '#1DC7EA',
  // This has to be the same size as the maximum width to
  // prevent clipping
  strokeWidth: 10,
  trailWidth: 10,
  easing: 'easeInOut',
  duration: 1400,
  text: {
    autoStyleContainer: false
  },
  from: { color: '#1DC7EA', width: 10 },
  to: { color: '#1DC7EA', width: 10 },
  // Set default step function for all animate calls
  step: function(state, circle) {
    circle.path.setAttribute('stroke', state.color);
    circle.path.setAttribute('stroke-width', state.width);

    var value = Math.round(circle.value() * 100);
    if (value === 0) {
      circle.setText('');
    } else {
      circle.setText(value + "%");
    }

  }
});
bar2.text.style.fontFamily = '"Raleway", Helvetica, sans-serif';
bar2.text.style.fontSize = '4rem';
bar2.animate(0.05);  // Number from 0.0 to 1.0



var brw= 2; // treba ova da se zeme od kontejner za da znaeme do kolku decimali da se ode 
//spored podatocite sho kje se najdat soodvetno za sekoj progress bar


var bar3 = new ProgressBar.Circle("#container3", {
  color: '#ED8D00',
  // This has to be the same size as the maximum width to
  // prevent clipping
  strokeWidth: 10,
  trailWidth: 10,
  easing: 'easeInOut',
  duration: 1400,
  br: brw,
  text: {
    autoStyleContainer: false
  },
  from: { color: '#ED8D00', width: 10 },
  to: { color: '#ED8D00', width: 10 },
  // Set default step function for all animate calls
  step: function(state, circle, atachment) {
    circle.path.setAttribute('stroke', state.color);
    circle.path.setAttribute('stroke-width', state.width);
        var broj = 1;
    var i;
    for (i = 0; i < this.br; i++)
      broj *= 10;
    var value = Math.round(circle.value() * broj);
    if (value === 0) {
      circle.setText('');
    } else {
      circle.setText(value + "%");
    }

  }
});
bar3.text.style.fontFamily = '"Raleway", Helvetica, sans-serif';
bar3.text.style.fontSize = '4rem';
bar3.animate(0.01);  // Number from 0.0 to 1.0

$("#btnLand").click(function(){
  $(".cont-weather").hide();
  $(".cont-landslide").show();
});

$("#btnWeat").click(function(){
  $(".cont-landslide").hide();
  $(".cont-weather").show();
});

$("#btnSearchAddress").click(function() {
    $("#infoLog").removeClass("hidden");
});


function wheaterPredict(myLatInit,myLngInit){
    var vreme_text = {};
  $(document).ready(function() {
    for (var i = 1; i < 30; i++) {
      var date = new Date();
      date.setDate(date.getDate()-i);
      $.ajax({
      url: "http://api.apixu.com/v1/history.json?key=da777950c5cc4df4ab952956173004&q="+myLatInit+","+myLngInit+"&dt="+date.toISOString().split("T")[0]
      })
      .done(function( data ) {
        var item = data['forecast']['forecastday'][0]['day']['condition']['text'];
        //var rainPredic=data['forecast']['forecastday'][0]['day']['totalprecip_mm'];
        var c = item.split(" ")[0];
        if ($("#history > ."+ c).length==0) {
          $("#history").append("<div class='"+c+"' num='1'>"+item + ": 1 day</div>");//,   Rain:" + rainPredic+"mm<sup>3</mm>");
        }
        else {
          var num = parseInt($("#history > ."+c).attr("num"));
          num++;
          $("#history > ."+c).remove();
          $("#history").append("<div class='"+c+"' num="+num+">"+item + ": "+num+ " days</div>");//,    Rain:" + rainPredic+"mm<sup>3</mm>");
        }
      });
    }
  $(document).ready(myFunction());
    function myFunction() {
      $.ajax({
      url: "http://api.apixu.com/v1/forecast.json?key=da777950c5cc4df4ab952956173004&q="+myLatInit+","+myLngInit+"&days=10"
      })
      .done(function( data ) {
        for (var k in data['forecast']['forecastday']) {
        var item = data['forecast']['forecastday'][k]['day']['condition']['text'];
        var rainPredic=data['forecast']['forecastday'][k]['day']['totalprecip_mm'];
        var c = item.split(" ")[0];
        if ($("#forecast > ."+ c).length==0) {
          $("#forecast").append("<div class='"+c+"' num='1'>"+item + ": 1 day</div>");//,    Rain:" + rainPredic+"mm<sup>3</mm>");
        }
        else {
          var num = parseInt($("#forecast > ."+c).attr("num"));
          num++;
          $("#forecast > ."+c).remove();
          $("#forecast").append("<div class='"+c+"' num="+num+">"+item + ": "+num+" days</div>");//,    Rain:" + rainPredic+"mm<sup>3</mm>");
        }
      }
      });
    }

    
  });
}

function inside(point, vs) {

    // ray-casting algorithm based on
    // http://www.ecse.rpi.edu/Homepages/wrf/Research/Short_Notes/pnpoly.html

    var x = point[0], y = point[1];

    var inside = false;
    for (var i = 0, j = vs.length - 1; i < vs.length; j = i++) {
        var xi = vs[i][0], yi = vs[i][1];
        var xj = vs[j][0], yj = vs[j][1];

        var intersect = ((yi > y) != (yj > y))
            && (x < (xj - xi) * (y - yi) / (yj - yi) + xi);
        if (intersect) inside = !inside;
    }

    return inside;
}


function landslideZone(myLngInit,myLatInit){
  var point = [myLngInit, myLatInit];
  var nowcast = 0;
  var tekst = ""; 
  $.ajax({
          url: "https://pmmpublisher.pps.eosdis.nasa.gov/products/global_landslide_nowcast/export/Global/2017/117/global_landslide_nowcast_20170427.geojson"
        })
          .done(function(data) {
            for(var item in data['features']) {
              // console.log(data['features'][item]['geometry']['coordinates'][0]);
              var isInside = inside(point,data['features'][item]['geometry']['coordinates'][0]);
              
              if (isInside) {
                nowcast = parseInt(data['features'][item]['properties']['nowcast']);
                }

                console.log();
              }
              var tip='info';
              switch(nowcast) {
                case 0: console.log("No Risk"); tekst="No Risk"; break;
                case 1: console.log("Low Risk"); tekst="Low Risk"; tip='warning'; break;
                case 2: console.log("Medium Risk"); tekst="Medium Risk"; tip='danger'; break;
                case 3: console.log("High Risk"); tekst="High Risk"; tip='danger'; break;
              }
              $.notify({
                 icon: 'pe-7s-info',
                 message: tekst
              },{
                  type: tip,
                  timer: 4000
              });

        });
}
function findLandslides(latInit, lngInit) {
$.ajax({
  url: "https://data.nasa.gov/resource/tfkf-kniw.json?$where=within_circle(geolocation," + latInit +"," + lngInit +",50000)"
})
.done(function(data) {
  for(var item in data) {
    var trigger = data[item]['trigger'];
    var title = data[item]['near'];
    var nearest_places = data[item]['nearest_places'];
    var lat = data[item]['latitude'];
    var lng = data[item]['longitude'];
    
    var content = "<div id=" + title +">" +
    "<b>Landslide</b>: " + title + "<br>" + 
    "Triggered by: " + trigger + "<br>" +
    "Near: " + nearest_places +
    "</div><hr>";
    $(".cont-landslide").append(content);
  }
});
}
</script>

</html>
