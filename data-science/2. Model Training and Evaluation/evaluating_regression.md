# Evaluating Regression Models
Unlike classification, an easy way to see if your model is working well is just through plotting your predictions against the actual values on a graph. Besides that, there are some metrics that you can use to numerically evaluate your model.

## Getting $R^{2}$

Before we talk about the [coefficient of determination](https://en.wikipedia.org/wiki/Coefficient_of_determination), we should first understand what R is. [R](https://en.wikipedia.org/wiki/Correlation_coefficient) is the correlation coefficient that measures the strength and direction of the linear relationship between two variables. In your EDA, you might have done a correlation plot to see what variables have what correlation with each other. A value of $-1$ or $1$ means that they have a strong correlation whereas the value of $0$ means that there is no correlation. 

Here, $R^{2}$ is simply the square of that value for the correlation between our predictions and the ground truth (actual y values). This [short video](https://www.youtube.com/watch?v=bMccdk8EdGo) explains why we square the R value.

By getting an $R^{2}$ value of $100\\%$, we can say that our input features explain $100\\%$ of the variance in the dataset which is a fancy of saying that the model works *perfectly*. While on the other hand, getting an R squared value of, let's say, $5\\%$ means that our input features explain only $5\\%$ of the variation in the dataset, where the other $95\\%$ must be explained by some other features.

Getting the $R^{2}$ value in ```sklearn``` can be done by:
```python
from sklearn.metrics import r2_score

# Assuming you have your actual target and predictions

# Calculate the R-squared value
r2 = r2_score(y_test, predictions)

print("R-squared:", r2)
```

## Getting the MSE

A good way to see how far off a prediction is by using Mean Square Error (MSE). We define error as the difference between the prediction and the actual value. So by squaring each error, MSE punishes big errors more than Mean Absolute Error (MAE).
$$\sum_{i=1}^{D}(x_i-y_i)^2$$

In ```sklearn```, this is simple:

```python
from sklearn.metrics import mean_squared_error

# Calculate the MSE
mse = mean_squared_error(y_true, y_pred)

print("Mean Squared Error:", mse)

```

From this, you can root it to find the Root Mean Squared Error (RMSE):
$$\sqrt{\sum_{i=1}^{D}(x_i-y_i)^2}$$
```
import numpy as np

rmse = np.sqrt(mse)
print("Root Mean Squared Error:", rmse)
```


## Getting the MAE

Mean Absolute Error(MAE) is similar to MSE except we only take the absolute value of the errors.

$$\sum_{i=1}^{D}|x_i-y_i|$$

With ```sklearn```, this is:
```
from sklearn.metrics import mean_absolute_error

# Calculate the MAE
mae = mean_absolute_error(y_test, predictions)

print("Mean Absolute Error:", mae)
```


<br>

For MSE, RMSE and MAE, the lower the value the better it is for our predictions.
