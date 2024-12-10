const path = require('path');

module.exports = {
    resolve: {
        fallback: {
            fs: require.resolve('browserify-fs'),
            path: require.resolve('path-browserify'),
            util: require.resolve('util/')
        }
    }
};
