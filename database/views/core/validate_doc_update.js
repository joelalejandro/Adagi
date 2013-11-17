function(newDoc, savedDoc, userCtx) {
  var require = function(field, message) {
    message = message || 'Object must have a ' + field;
    if (!newDoc[field]) throw({forbidden: message});
  };

  require('$docType');
};