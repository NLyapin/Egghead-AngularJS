//function ObjectName(param1, param2){
//    this.param1 = param1;
//    this.param2 = param2;
//    this.toString = function(){
//        return this.param1 + ' ' this.param2;
//    }
//}

var Task = function(name){
    this.name = name;
    this.completed = false;
}

Task.prototype.complete = function(){
    console.log('completing task: ' + this.name);
    this.completed = true;
}

Task.prototype.save = function(){
    console.log('saving Task: ' + this.name);
}

module.exports = Task;
