app.directive('ngEnter', function () {
  return function (scope, element, attrs) {
    scope.shiftPressed = false;

    element.bind("keyup", function (event) {
      if (event.which === 16) {
        scope.shiftPressed = false;
      }
    });
    element.bind("keydown keypress", function (event) {
      if (event.which === 16) {
        scope.shiftPressed = true;
      }
      if (event.which === 13 && !scope.shiftPressed) {
        scope.$apply(function () {
          scope.$eval(attrs.ngEnter);
        });

        event.preventDefault();
      }
    });
  };
});