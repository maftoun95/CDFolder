var express = require('express');
var app = express();
var bodyParser = require('body-parser');
var obj;

app.use(bodyParser.urlencoded({extended: true}));
app.use(express.static(__dirname + "/static"));
app.set("views", __dirname + "/views");
app.set('view engine', 'ejs');

app.get('/', function(req,res){
    if (res.obj){
        res.render('/index.html', {data:res.obj})
    } else {
        res.render('/index.html')
    }
})

app.listen(8000, function(){
    console.log('were in bussiness')
})

app.post('/doWork', function(req,res){
    console.log(req.body);
    obj = {
        name: req.body.name,
        loc: req.body.loc,
        lang: req.body.lang,
        comment: req.body.comment,
    }

    res.redirect('/doWork')
})
app.get('/doWork', function(req,res){

    res.render('result', {data:obj})
})