$(function() {
  $("#dataDiv").data("name", "Saman");
  $( "#click" ).click(function() {
    alert("You clicked the button! You can make anything you click on do anything you want using .click! In fact, we're going to use it for the rest of this page.");
  });
  $( "#hide" ).click(function() {
    $( "#makeHidden").hide();
  });
  $("#show").click(function() {
    $( "#makeHidden" ).show();
  });
  $("#toggle").click(function() {
    $( "#toggledText" ).toggle("slow");
  });
  $("#slideDown").click(function() {
    $( "#slideDownText" ).slideDown();
  });
  $("#slideUp").click(function() {
    $( "#slideDownText" ).slideUp();
  });
  $("#slideToggle").click(function() {
    $( "#slideToggleText" ).slideToggle();
  });
  $("#fadeIn").click(function() {
    $("#fadeInText, #fadeOutButton").fadeIn();
  });
  $("#fadeOutButton").click(function() {
    $("#fadeInText, #fadeOutButton, #fadeOutText").fadeOut();
  });
  $("#addClass").click(function() {
    $("div").addClass("red");
    $("#removeClassDiv").show();
  });
  $("#removeClass").click(function() {
    $("div").removeClass("red");
  });
  $("#before").click(function() {
    $("#beforeHeader").before("<h1>Oh wow this is the coolest!</h1>");
  });
  $("#after").click(function() {
    $("#afterHeader").after("<h1>Oh wow this is slightly less cool. :(</h1>");
  });
  $("#append").click(function() {
    $("#groceryList").append("<li>Juice</li>");
  });
  $("#htmlButton").click(function() {
    alert($('#sampleDiv').html());
   });
  $("#attrButton").click(function() {
    $("#targetDiv").attr("class", "attrExample");
  });
  $("#valButton").click(function() {
    alert("You entered: " + $("#valInput").val());
  });
  $("#BIGPAPABUTTON").click(function() {
    alert($("#BIGPAPA").text());
  });
  $("#dataButton").click(function() {
    alert($("#dataDiv").data("name"));
  });
});
