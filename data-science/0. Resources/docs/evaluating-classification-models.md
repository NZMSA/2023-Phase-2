# Evaluating Classification Models

Evaluating leads directly on from testing your model. A good accuracy on your test set is not enough to say that your model is useful! Your model could be overfitting on the test set, your dataset may contain samples that belong to one class far more than the other class/es, and your classification model could simply be choosing the majority class which would automatically yield a high accuracy without any "learning" taking place.

We would like you to evaluate your model using the following model evaluation techniques for your classification model/s:

1. Confusion matrix
    - Plot confusion matrices with labels and axes for clarity
2. Precision, recall, F1-score
    - Calculate and display your precision, recall, and F1-score
3. ROC and AUC
    - If you are using a logistic regression model, show the results of an ROC and AUC analysis

## 1. Confusion matrix

A model that has a high test accuracy can do more harm than good. Imagine if you were dealing with a dataset for a serious disease that only 1 out of 1000 people have. A model trained on this dataset of 1000 patients could have an accuracy of 99.9% by simply predicting "does not have disease" for each patient, but this metric wouldn't be useful because it tells us nothing about the model's ability to detect that one patient who actually does have the disease. 

With this in mind, we can calculate four different values - true positives (TP), true negatives (TN), false positives (FP), false negatives (FN) to provide a better view of our model's performance. These values can be displayed on a confusion matrix, as shown below:
```python
from sklearn.metrics import confusion_matrix
cm = confusion_matrix(y_test, predictions)
```

## 2. Precision, recall, F1-score

The four values above can be used to calculate [precision and recall](https://en.wikipedia.org/wiki/Precision_and_recall).
- Precision: The fraction of actual positive instances among all instances that were predicted to be positive (TP / (TP + FP))
    - In other words, out of all the patients who were predicted to have the disease, how many actually had the disease? For the example above, no patients were predicted by our model to have the disease, so our precision will be $0/0 = undefined$ (note that Scikit-learn will return an undefined value as 0).
- Recall: The fraction of actual positive instances among all instances are actually positive (TP / (TP + FN))
    - In other words, out of all the patients who have the disease (i.e. our relevant instances), how many were predicted by our model to have the disease? For the example above, only 1 patient had the disease but that patient was not predicted by our model to have the disease, so our recall will be $0/1 = 0$.

Precision and recall can then be used to calculate the F1-score, which simply balances precision and recall to get one single number that can give us a good sense of how well a model is performing:
$$F1score = 2 * \frac{(precision * recall)}{(precision + recall)}$$

For the example above, the F1-score will be 0, quantifiably confirming that the disease model is not useful for predicting patients who have the disease. Depending on the problem, we can choose to pay more attention to precision or recall - for the example above, we would pay more attention to recall because, while we wouldn't mind predicting that some patients who don't have the disease actually do, we don't want to predict that patients (who actually have the disease) don't have it.

All the values above can be calculated as shown below:
```python
from sklearn.metrics import classification_report
cr = classification_report(y_test, predictions)
```

3. ROC and AUC

Precision and recall can be used to calculate true positive rate (TPR) and false positive rate (FPR):
- Recall and true positive rate are exactly the same
- False positive rate (FP / (FP + TN)) is the fraction of incorrect positive instances among all instances that are actually negative.
    - In other words, out of all the patients who do not have the disease, how many were predicted to have the disease? For the example above, 999 patients did not have the disease and none were predicted to have the disease, so our FPR will be $0/999 = 0$

TPR and FPR can be be plotted against each other to get evaluation metrics such as the receiver operating characteristic (ROC) curve and the area under the curve (AUC) by changing the threshold of a logistic regression model for a positive or negative classification, as explained in this Microsoft Learn module: [Measure and optimize model performance with ROC and AUC](https://learn.microsoft.com/en-us/training/modules/optimize-model-performance-roc-auc).