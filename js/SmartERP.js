// SmartERP.js — Chart.js interop bridge for Blazor WASM
// All functions are namespaced under window.SmartERP to avoid collisions.

window.SmartERP = (function () {
    'use strict';

    const _charts = {};   // registry: canvasId → Chart instance

    /**
     * Build a Chart.js config object from the Blazor ChartData model.
     */
    function buildConfig(chartData) {
        return {
            type: 'line',
            data: {
                labels: chartData.labels,
                datasets: chartData.datasets.map(ds => ({
                    label:           ds.label,
                    data:            ds.data,
                    borderColor:     ds.borderColor,
                    backgroundColor: ds.backgroundColor,
                    fill:            ds.fill,
                    tension:         ds.tension / 10,   // C# sends int × 10
                    borderWidth:     2.5,
                    pointRadius:     4,
                    pointHoverRadius:6,
                }))
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                interaction: { mode: 'index', intersect: false },
                plugins: {
                    legend: {
                        display: false   // Custom legend rendered in Blazor
                    },
                    tooltip: {
                        backgroundColor: 'rgba(15, 23, 42, 0.92)',
                        titleColor:      '#e2e8f0',
                        bodyColor:       '#94a3b8',
                        borderColor:     'rgba(255,255,255,0.08)',
                        borderWidth:     1,
                        padding:         12,
                        cornerRadius:    8,
                    }
                },
                scales: {
                    x: {
                        grid:  { color: 'rgba(255,255,255,0.05)' },
                        ticks: { color: '#64748b', font: { family: 'Inter, sans-serif', size: 11 } }
                    },
                    y: {
                        grid:  { color: 'rgba(255,255,255,0.05)' },
                        ticks: { color: '#64748b', font: { family: 'Inter, sans-serif', size: 11 } },
                        beginAtZero: false
                    }
                },
                animation: { duration: 700, easing: 'easeInOutQuart' }
            }
        };
    }

    return {

        /** Create a new Chart.js instance for a given canvas element. */
        initChart: function (canvasId, chartData) {
            if (_charts[canvasId]) {
                _charts[canvasId].destroy();
                delete _charts[canvasId];
            }
            const ctx = document.getElementById(canvasId);
            if (!ctx) { console.warn('[SmartERP] Canvas not found:', canvasId); return; }
            _charts[canvasId] = new Chart(ctx.getContext('2d'), buildConfig(chartData));
        },

        /** Update data on an existing chart with smooth animation. */
        updateChart: function (canvasId, chartData) {
            const chart = _charts[canvasId];
            if (!chart) { this.initChart(canvasId, chartData); return; }

            chart.data.labels   = chartData.labels;
            chart.data.datasets = chartData.datasets.map((ds, i) => ({
                ...chart.data.datasets[i],
                label:           ds.label,
                data:            ds.data,
                borderColor:     ds.borderColor,
                backgroundColor: ds.backgroundColor,
                fill:            ds.fill,
            }));
            chart.update();
        }
    };
})();
