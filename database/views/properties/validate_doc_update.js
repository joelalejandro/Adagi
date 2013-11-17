function(newDoc, savedDoc, userCtx) {
  var type = (newDoc || savedDoc)['$docType'];
  var require = function(field, message) {
    message = message || 'Property must have a ' + field;
    if (!newDoc[field]) throw({forbidden: message});
  };

  if (type == 'property') {  
    require('referenceCode');
    require('type');
    require('features');
    require('createdBy');
  }
};