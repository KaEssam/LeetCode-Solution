/**
 * @param {Function[]} functions
 * @return {Function}
 */
var compose = function(functions) {
    
    return function(x) {
    if(functions.length == 0){
      return x;
    }else{
      for(let i=functions.length; i--; i>0){
        x=functions[i](x)
      }
      return x
    }
}
};

/**
 * const fn = compose([x => x + 1, x => 2 * x])
 * fn(4) // 9
 */