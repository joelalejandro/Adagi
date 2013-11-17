function(doc) {
  if (doc.$docType == 'property') {  
    emit(doc.referenceCode, doc);
  }
};