class Solution {
    /**
     * @param {number[]} arr
     * @return {number[]}
     */
    replaceElements(arr) {

        let max = arr[arr.length - 1];

        for (let i = arr.length - 2; i >= 0; i--) {

            if (arr[i] <= max) {

                arr[i] = max;

            }
            else {

                let temp = arr[i]
                arr[i] = max;
                max = temp

            }

        }

        arr[arr.length - 1] = -1

    return arr
    }
}
