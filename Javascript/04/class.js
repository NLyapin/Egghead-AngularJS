'use strict'

class Task {
        constructor(data) {
            this.name = data.name;
            this.completed = false;

        }

        complete() {
            console.log('completing task: ' + this.name);
            this.completed = true;
        }


        save() {
            console.log('saving Task: ' + this.name);
            Repo.save(this);
        }
    }

var task1 = new Task('create a demo for constructors');
var task2 = new Task('create a demo for modules');
var task3 = new Task('create a demo for singletons');
var task4 = new Task('create a demo for prototypes');

task1.save();
task2.save();
task3.save();
task4.save();