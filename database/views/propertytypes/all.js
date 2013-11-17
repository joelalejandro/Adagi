function(doc) {
  if (doc.$docType == 'propertytype') {  
    emit(null, doc);
  }
};