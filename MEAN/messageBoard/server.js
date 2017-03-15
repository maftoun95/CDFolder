var express = require('express');
var app = express();
var bp = require('body-parser');
var path = require('path');
var mongoose = require('mongoose');

//4 apps, 2 uses 2 sets
app.use(bp.urlencoded({extended:true}));
app.use(express.static(path.join(__dirname,'./static')));
app.set('views',path.join(__dirname,'./views'));
app.set('view engine','ejs');

mongoose.Promise = global.Promise;
mongoose.connect('mongodb://localhost/messageBoard');
//SCHEMAS

app.get('/', function(req,res){
    res.render('index')
})

app.listen(8000, function(){
    console.log('Usain Bolt')
})