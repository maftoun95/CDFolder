var express = require('express');
var app = express();
var path = require('path');

var PORT = 8000

app.use(express.static(path.join(__dirname, './client')))
app.use(express.static(path.join(__dirname, './node_modules')))

app.listen(PORT, function(){
    console.log('Usain Boltz');
});