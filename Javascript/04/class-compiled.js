'use strict';

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var Task = function () {
    function Task(data) {
        _classCallCheck(this, Task);

        this.name = data.name;
        this.completed = false;
    }

    _createClass(Task, [{
        key: 'complete',
        value: function complete() {
            console.log('completing task: ' + this.name);
            this.completed = true;
        }
    }, {
        key: 'save',
        value: function save() {
            console.log('saving Task: ' + this.name);
            Repo.save(this);
        }
    }]);

    return Task;
}();

var task1 = new Task('create a demo for constructors');
var task2 = new Task('create a demo for modules');
var task3 = new Task('create a demo for singletons');
var task4 = new Task('create a demo for prototypes');

task1.save();
task2.save();
task3.save();
task4.save();

//# sourceMappingURL=class-compiled.js.map